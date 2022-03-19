import { Component } from '@angular/core';
import { Customer } from '../models/customer';
import { CustomerService } from '../services/customer.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {

  constructor(private customerService: CustomerService) {
  }

  public customer: Customer = new Customer();
  public successMessage: string = '';
  public errorMessage: string = '';

  clean() {
    this.successMessage = '';
    this.errorMessage = '';
    this.customer = new Customer();
  }

  save() {
    this.successMessage = '';
    this.errorMessage = '';
    this.customerService.create(this.customer)
      .subscribe(response => {
        if (response) {
          this.successMessage = 'Customer has been created';
          this.customer = new Customer();
        } else {
          this.errorMessage = 'Error trying to save the customer';
        }
      }, 
      error => { 
        this.errorMessage = error.name;
        console.error(error); 
      });
  }
}
