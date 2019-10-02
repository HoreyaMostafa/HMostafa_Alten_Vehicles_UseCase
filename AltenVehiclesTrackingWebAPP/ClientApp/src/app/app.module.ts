import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { VehiclesComponent } from './vehicles/vehicles.component';
import { HttpClientModule } from '@angular/common/http';
import { RepositoryService } from './shared/services/repository.service';
import { FormsModule } from '@angular/forms';

@NgModule({
  declarations: [
    AppComponent,
    VehiclesComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    FormsModule      
  ],
  providers: [RepositoryService],
  bootstrap: [AppComponent]
})
export class AppModule { }
