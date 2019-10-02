import { Component, OnInit } from '@angular/core';
import { RepositoryService } from './../shared/services/repository.service';
import { Vehicle } from './../interfaces/vehicle.model';

@Component({
  selector: 'app-home',
  templateUrl: './vehicles.component.html',
  styleUrls: ['./vehicles.component.css']
})

export class VehiclesComponent implements OnInit {

  public homeText: string;
  public vehicles: Vehicle[];

  constructor(private repository: RepositoryService) { }

  ngOnInit() {
    this.homeText = "WELCOME TO Alten-Vehicles Monitoring APPLICATION";
   this.getAllOwners();
  }

  public getAllOwners() {
    this.repository.getVehicles()
      .subscribe(res => {
        this.vehicles = res as Vehicle[];
      })
  }
}
