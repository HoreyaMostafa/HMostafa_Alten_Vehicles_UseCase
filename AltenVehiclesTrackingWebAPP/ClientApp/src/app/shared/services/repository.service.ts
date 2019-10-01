import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';

@Injectable()
export class RepositoryService {

  constructor(private http: HttpClient) { }

  public getVehicles() {
    var ff = this.http.get('http://localhost:5000/api/vehicle');
    return ff;
  }


}
