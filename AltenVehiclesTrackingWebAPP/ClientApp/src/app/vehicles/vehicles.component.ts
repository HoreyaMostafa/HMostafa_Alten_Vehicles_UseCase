import { Component, OnInit } from '@angular/core';
import { RepositoryService } from './../shared/services/repository.service';
import { Vehicle } from './../interfaces/vehicle.model';
import { Customer } from './../interfaces/customer.model';

@Component({
  selector: 'app-home',
  templateUrl: './vehicles.component.html',
  styleUrls: ['./vehicles.component.css']
})

export class VehiclesComponent implements OnInit {

  public homeText: string;
  public vehicles: Vehicle[];
  public customers: Customer[];
  public filterCustomerID: number = -1;
  public filterIsConnected: number = -1;
  public vehicleStatus: Array<any> = [{ id: 1, type: 'Connected', value: true }, { id: 0, type: 'Disconnected', value: false }];;

  constructor(private repository: RepositoryService) { }

  ngOnInit() {
    this.homeText = "WELCOME TO Alten-Vehicles Monitoring APPLICATION";
    this.getAllVehicles();
    this.getAllCustomers()
  }

  public getAllVehicles() {
    this.repository.getVehicles()
      .subscribe(res => {
        this.vehicles = res as Vehicle[];
      })
  }
  public getAllCustomers() {
    this.repository.getCustomers()
      .subscribe(res => {
        this.customers = res as Customer[];
      })
  }

  public executeSearch() {

    if (this.filterCustomerID != -1)
      this.repository.GetVehiclesByCustomer(this.filterCustomerID)
        .subscribe(res => {
        this.vehicles = res as Vehicle[];
        })
    else if (this.filterIsConnected !=-1 )
      this.repository.GetVehiclesByStatus(this.filterIsConnected)
        .subscribe(res => {
          this.vehicles = res as Vehicle[];
        })
    else this.getAllVehicles();
  }


  changefilterCustomer(e) {
    if (e.value != -1)
      this.filterIsConnected = -1;
  } 
  changefilterStatus(e) {
    if (e.value != -1)
      this.filterCustomerID = -1;
  } 
}
