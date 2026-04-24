import { Component } from '@angular/core';
import { Product } from '../product';
import { FormsModule } from '@angular/forms';
@Component({
  selector: 'app-product-component',
  imports: [FormsModule],
  templateUrl: './product-component.html',
  styleUrl: './product-component.css',
})
export class ProductComponent {
  product: Product;
  products: Product[] = [];
  constructor(){
    this.product = {
      id : 0,
      name : "",
      price : 0,
      quantity : 0
    }
  }

  
}
