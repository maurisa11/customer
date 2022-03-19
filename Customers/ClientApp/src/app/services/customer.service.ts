import { Injectable, OnInit, EventEmitter } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Customer } from '../models/customer';

@Injectable()
export class CustomerService {

  private endpoints = {
    get: '/api/customers',
    create: '/customers/create'
  }
  constructor(private http: HttpClient) {
  }


  create(customer: Customer) {
    let httpHeaders = new HttpHeaders({
      'Content-Type': 'application/json',
      'Cache-Control': 'no-cache'
    });
    let options = {
      headers: httpHeaders
    };

    console.log(JSON.stringify(customer))
    return this.http.post(this.endpoints.create, JSON.stringify(customer), options);
  }


}
