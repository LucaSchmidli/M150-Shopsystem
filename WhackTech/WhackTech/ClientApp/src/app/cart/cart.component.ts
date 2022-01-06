import { Component, OnInit } from '@angular/core';
import { CartService } from 'src/app/service/cart.service';
import { ApiService } from 'src/app/service/api.service';
@Component({
  selector: 'app-cart',
  templateUrl: './cart.component.html',
  styleUrls: ['./cart.component.css']
})
export class CartComponent implements OnInit {

  public products : any = [];
  public grandTotal !: number;
  constructor(private api: ApiService,private cartService : CartService) { }

  ngOnInit(): void {
    this.cartService.getProducts()
    .subscribe(res=>{
      this.products = res;
      this.grandTotal = this.cartService.getTotalPrice();
    })
  }
  removeItem(item: any){
    this.cartService.removeCartItem(item);
  }
  emptycart(){
    this.cartService.removeAllCart();
  }

  createOrder() {
    this.api.postOrder();
  }
}

interface Product {
  Id: number;
  Name: string;
  Description: string;
  ImgUrl: string;
  Price: number;
}

interface Item {
  Id: number;
  ProductID: number;
  OrderID: number;
  Quantity: number;
  Price: number;
}

interface Order {
  Id: number;
  PaymentMethodID: number;
  TotalPrice: number;
  FirstName: string;
  LastName: string;
  Street: string;
  Country: string;
  PLZ: string;
  City: string;
  Items: Item[];
}
