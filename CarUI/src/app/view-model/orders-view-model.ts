import { UsersViewModel } from './users-view-model';
import { CarsViewModel } from './cars-view-model';
import { SupportsViewModel } from './supports-view-model';

export class OrdersViewModel{
    dateFrom: string;
    dateEnd: string;
    car: CarsViewModel;
    user: UsersViewModel;
   
    supports: SupportsViewModel;
    message: string;
}