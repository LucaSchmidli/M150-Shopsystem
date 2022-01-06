
import { Component, OnInit } from '@angular/core';
import { ApiService } from 'src/app/service/api.service';
import { CartService } from 'src/app/service/cart.service';

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.css']
})
export class ProductsComponent implements OnInit {

  public productList: Product[];
  //public productList: any;
  public filterCategory: any
  searchKey: string = "";
  constructor(private api: ApiService, private cartService: CartService) { }

  ngOnInit(): void {
    this.api.getProduct()
      .subscribe(res => {
        this.productList = res;
        this.filterCategory = res;
        this.productList.forEach((a: any) => {

          Object.assign(a, { quantity: 1, total: a.price });
        });
        console.log(this.productList)
      });

    this.cartService.search.subscribe((val: any) => {
      this.searchKey = val;
    })
  }


  addtocart(item: Product) {
    this.cartService.addtoCart(item);
  }
  filter(category: string) {
    this.filterCategory = this.productList
      .filter((a: any) => {
       // if (a.category == category || category == '') {
          return a;
        //}
      })
  }

}
interface Product {
  Id: number;
  Name: string;
  Description: string;
  ImgUrl: string;
  Price: number;
}
