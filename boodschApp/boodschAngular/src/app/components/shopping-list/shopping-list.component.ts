import { Component, OnInit } from '@angular/core';
import { ShoppingItem } from '../../models/shopping-item';
import { ShoppingItemsService } from '../../services/shopping-items.service';

@Component({
  selector: 'app-shopping-list',
  templateUrl: './shopping-list.component.html',
  styleUrls: ['./shopping-list.component.css']
})
export class ShoppingListComponent implements OnInit {
  items: ShoppingItem[] = [];

  constructor(private service: ShoppingItemsService) { }

  ngOnInit(): void {
    this.service.getShoppingItems().subscribe(value => this.items = value);
  }

}
