import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { catchError, tap } from 'rxjs/operators';
import { environment } from '../../environments/environment';
import { ShoppingItem } from '../models/shopping-item';

@Injectable({
  providedIn: 'root'
})
export class ShoppingItemsService {
  private shoppingUrl: string = environment.shoppingEndpoint;  // URL to web api

  constructor(private http: HttpClient) { }

  public getShoppingItems(): Observable<ShoppingItem[]> {

    return this.http.get<ShoppingItem[]>(this.shoppingUrl)
      .pipe(
        catchError(error => this.HandleError<ShoppingItem[]>(error, [], 'getShoppingItems'))
      )
  }

  private HandleError<T>(error: any, result?: T, operation: string = 'operation'): Observable<T> {

    console.error(`${operation} failed: ${error.message}`);
    console.error(error);

    // Let the app keep running by returning an empty result.
    return of(result as T);
  }
}
