import { Component, OnInit, OnDestroy } from '@angular/core';
import { UsersViewModel } from 'src/app/view-model/users-view-model';
import { MovingService } from 'src/app/services/moving.service';
import { FormGroup, FormControl, Validators, ValidatorFn } from '@angular/forms';
import { OrdersViewModel } from 'src/app/view-model/orders-view-model';
import { CarsViewModel } from 'src/app/view-model/cars-view-model';
import { SupportsViewModel } from 'src/app/view-model/supports-view-model';

@Component({
  selector: 'app-order-form',
  templateUrl: './order-form.component.html',
  styleUrls: ['./order-form.component.scss']
})
export class OrderFormComponent implements OnInit, OnDestroy {

  user = new UsersViewModel();
  public cars: Array<string>;
  public supportsAll: Array<string>;
  default = 'SELECT YOUR CAR';
  isActive = false;

  orderForm = new FormGroup({});
  dateFrom1 = new FormControl('', Validators.required);
  timeFrom1 = new FormControl('', Validators.required);
  dateEnd = new FormControl('', Validators.required);
  timeEnd = new FormControl('', Validators.required);
  transmission = new FormControl(false);
  maintenance = new FormControl(false);
  rapair = new FormControl(false);
  other = new FormControl(false);
  carYear = new FormControl();
  carModel = new FormControl(this.default);
  message = new FormControl();
  firstName = new FormControl();
  lastName = new FormControl();
  email = new FormControl();
  phone = new FormControl();

  support = new FormControl(false);

  signUpForm = new FormGroup({});
  emailSignUp = new FormControl('');

  constructor(private _movingService: MovingService) {
   this.addControls();

  }

  ngOnInit() {
    this._movingService.getCars()
          .subscribe(
              (responce: Array<string>) => {
                  this.cars = responce;
              },
              error => {
                  alert('Server error.');
              }
          );
  }

  public sendData(){
    if(!this.orderForm.valid) {
      return;
    }
    else {
      const order = new OrdersViewModel();
      order.dateFrom = this.dateFrom1.value + ' ' + this.timeFrom1.value;
      order.dateEnd = this.dateEnd.value + ' ' + this.timeEnd.value;

      if (this.carYear.value !== '' || this.carModel.value !== '') {
          order.car = new CarsViewModel();

          if (this.carYear.value !== '') {
              order.car.year = this.carYear.value;
          }
          if (this.carModel.value !== '') {
              order.car.name = this.carModel.value;
          }
        order.message = this.message.value;

        order.user = new UsersViewModel();
        order.user.email = this.email.value;
        order.user.firstName = this.firstName.value;
        order.user.lastName = this.lastName.value;
        order.user.phone = this.phone.value;

         if (this.transmission.value) {
           order.supports = new SupportsViewModel();
            order.supports.name = 'Transmission';
          }
          else if (this.maintenance.value) {
           order.supports = new SupportsViewModel();
           order.supports.name = 'Vehicle Maintenance';
          }
          else if (this.rapair.value) {
           order.supports = new SupportsViewModel();
           order.supports.name = 'Vehicle Repair';
          }
          else if (this.other.value) {
           order.supports = new SupportsViewModel();
           order.supports.name = 'Other';
          }

        console.log(order);

        this._movingService.create(order).subscribe((responce) => {
            if (responce) {
                alert('Your order created successfully.');
            }
            else {
                alert('We cannot create order on this time, change time.');
            }
          }, error => {
                  alert('Server error.');
        });
      }
    }
  }

  public singUp(){
    if (this.emailSignUp.invalid) {
      return;
    }

    const user = new UsersViewModel();
    user.email = this.emailSignUp.value;
    const userSignUp = true;

    this._movingService.putUser(user)
        .subscribe(
            (responce) => {
                if (responce) {
                    alert('Email successfully sent');
                } else {
                    alert('Cannot send email for this user. Please, create the order for begining or register!');
                }
            },
            error => {
                alert('Server error.');
            }
        );

      this.clearData();
  }

  private addControls(){
    this.orderForm.addControl('dateFrom1', this.dateFrom1);
    this.orderForm.addControl('timeFrom1', this.timeFrom1);
    this.orderForm.addControl('dateFrom2', this.dateEnd);
    this.orderForm.addControl('timeFrom2', this.timeEnd);
    this.orderForm.addControl('transmission', this.transmission);
    this.orderForm.addControl('maintenance', this.maintenance);
    this.orderForm.addControl('rapair', this.rapair);
    this.orderForm.addControl('other', this.other);
    this.orderForm.addControl('carYear', this.carYear);
    this.orderForm.addControl('carModel', this.carModel);
    this.orderForm.addControl('message', this.message);
    this.orderForm.addControl('firstName', this.firstName);
    this.orderForm.addControl('lastName', this.lastName);
    this.orderForm.addControl('email', this.email);
    this.orderForm.addControl('phone', this.phone);

    this.orderForm.addControl('support', this.support);

    this.signUpForm.addControl('emailSignUp', this.emailSignUp);
  }

  private removeControls(){
    this.orderForm.removeControl('dateFrom1');
    this.orderForm.removeControl('timeFrom1');
    this.orderForm.removeControl('dateEnd');
    this.orderForm.removeControl('timeEnd');
    this.orderForm.removeControl('transmission');
    this.orderForm.removeControl('maintenance');
    this.orderForm.removeControl('rapair');
    this.orderForm.removeControl('other');
    this.orderForm.removeControl('carYear');
    this.orderForm.removeControl('carModel');
    this.orderForm.removeControl('message');
    this.orderForm.removeControl('firstName');
    this.orderForm.removeControl('lastName');
    this.orderForm.removeControl('email');
    this.orderForm.removeControl('phone');

    this.orderForm.removeControl('support');

    this.signUpForm.removeControl('emailSignUp');
  }

  clearData(){
    this.dateFrom1.setValue('');
    this.timeFrom1.setValue('');
    this.dateEnd.setValue('');
    this.timeEnd.setValue('');
    this.transmission.setValue('');
    this.maintenance.setValue('');
    this.rapair.setValue('');
    this.other.setValue('');
    this.carYear.setValue('');
    this.carModel.setValue(this.default);
    this.message.setValue('');
    this.firstName.setValue('');
    this.lastName.setValue('');
    this.email.setValue('');
    this.phone.setValue('');
  }
  clearSignUp(){
    this.emailSignUp.setValue('');
  }

  selectSupport(event) {
    console.log(event);
    // if (this.transmission.value) {
    //   this.isActive = !this.isActive;
    //  }
    //  else if (this.maintenance.value) {
    //   this.isActive = !this.isActive;
    //  }
    //  else if (this.rapair.value) {
    //  }
    //  else if (this.other.value) {
    //  }
  }

  ngOnDestroy(): void {
    this.removeControls();
  }

}
