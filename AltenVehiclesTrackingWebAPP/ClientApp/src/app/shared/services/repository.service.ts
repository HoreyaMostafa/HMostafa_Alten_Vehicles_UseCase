import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Vehicle } from './../../interfaces/vehicle.model';

@Injectable()
export class RepositoryService {

  constructor(private http: HttpClient) { }

  public getVehicles(): Observable<Vehicle[]> {
    return this.http.get<Vehicle[]>('http://localhost:5000/api/vehicle');
  }

}
