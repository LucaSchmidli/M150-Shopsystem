
import { Component, OnInit } from '@angular/core';
import { ApiService } from 'src/app/service/api.service';
import { CartService } from 'src/app/service/cart.service';
import { Router, ActivatedRoute, ParamMap } from '@angular/router';
import { switchMap } from 'rxjs/operators';

@Component({
  selector: 'app-detail',
  templateUrl: './detail.component.html',
  styleUrls: ['./detail.component.css']
})
export class DetailComponent implements OnInit {

  public product: Product;
  paramId: number;
  //public productList: any;
  public filterCategory: any
  searchKey: string = "";
  constructor(private api: ApiService, private cartService: CartService, private route: ActivatedRoute) {
    let paramString;
    this.route.paramMap.pipe(
      switchMap((params: ParamMap) => params.get('id')!)
    ).subscribe(string => paramString = string);
    this.paramId = Number(paramString);
  }

  ngOnInit(): void {
    this.api.getSingleProduct(this.paramId)
      .subscribe(res => {
        this.product = res;

        console.log(this.product)
      });
  }


  addtocart(item: Product) {
    this.cartService.addtoCart(item);
  }


}
interface Product {
  Id: number;
  Name: string;
  Description: string;
  ImgUrl: string;
  Price: number;
}
