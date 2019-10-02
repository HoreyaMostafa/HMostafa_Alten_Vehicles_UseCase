import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Vehicle } from './../../interfaces/vehicle.model';
import { Customer } from './../../interfaces/customer.model';

@Injectable()
export class RepositoryService {

  constructor(private http: HttpClient) { }

  public getVehicles(): Observable<Vehicle[]> {
    return this.http.get<Vehicle[]>('http://localhost:5000/api/vehicle');
  }
  public getCustomers(): Observable<Customer[]> {
    return this.http.get<Customer[]>('http://localhost:5001/api/customer');
  }
  public GetVehiclesByCustomer(customerId: number): Observable<Vehicle[]> {
    return this.http.get<Vehicle[]>('http://localhost:5000/api/vehicle/customer/' + customerId);
  }
  public GetVehiclesByStatus(status: number): Observable<Vehicle[]> {
    return this.http.get<Vehicle[]>('http://localhost:5000/api/vehicle/' + status);
  }

}
