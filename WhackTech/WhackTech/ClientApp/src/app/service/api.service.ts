import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import {map} from 'rxjs/operators';
@Injectable({
  providedIn: 'root'
})
export class ApiService {

  constructor(private http: HttpClient) { }

  getProduct(){
    return this.http.get<any>("https://localhost:44345/products")
    .pipe(map((res:any)=>{
      return res;
    }))
  }

  getSingleProduct(id) {
    return this.http.get<any>("https://localhost:44345/products/" +id)
      .pipe(map((res: any) => {
        return res;
      }))
  }

  postOrder() {

    const headers = new HttpHeaders()
      .set('Content-Type', 'application/json')
      .set('Accept', 'application/json')

    let testItem: Item = {
      Id: 1,
      OrderID: 1,
      ProductID: 1,
      Quantity: 1,
      Price: 1
    }
    let test: Order = {
      Id: null,
      PaymentMethodID: 1,
      TotalPrice: 100,
      FirstName: 'Luca',
      LastName: 'Schmidli',
      Country: 'Test',
      PLZ: '8143',
      City: 'Rümalang',
      Street: 'Test',
      Items: [testItem]
    }
    console.log(test);
    this.http.post<Order>("https://localhost:44345/Orders", test, { headers: headers }).subscribe(data => {
      console.log(data);
    })

  }

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
interface Product {
  Id: number;
  Name: string;
  Description: string;
  ImgUrl: string;
  Price: number;
}
