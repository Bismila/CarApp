import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { UsersViewModel } from '../view-model/users-view-model';
import { OrdersViewModel } from '../view-model/orders-view-model';

@Injectable({
  providedIn: 'root'
})
export class MovingService {

  baseUrl = 'https://localhost:44306/api/';
  constructor(private http: HttpClient) { }


  create(order: OrdersViewModel) {
    return this.http.post<OrdersViewModel>(this.baseUrl + 'order', order);
  }

  putUser(user: UsersViewModel){
    return this.http.put<UsersViewModel>(this.baseUrl + 'user', user);
  }

  getCars() {
    return this.http.get(this.baseUrl + 'cars');
  }

  getSupports(){
    return this.http.get(this.baseUrl + 'support');
  }
}
