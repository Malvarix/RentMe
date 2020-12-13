import { Component, OnInit } from '@angular/core';
import { BikeService } from 'src/app/shared/bike.service';
import { Bike } from '../entities/bike';
import { Status } from '../enums/status.enum';

@Component({
  selector: 'app-rent',
  templateUrl: './rent.component.html',
  providers: [ BikeService ]
})
export class RentComponent implements OnInit {

  public bike: Bike;
  public allBikes: Bike[];
  public availableBikes: Bike[];
  public rentedBikes: Bike[];
  

  constructor(private bikeService: BikeService) {
    this.bike = new Bike();
    this.allBikes = [];
    this.availableBikes = [];
    this.rentedBikes = [];
  }

  ngOnInit(): void {
    this.loadBikes();
  }

  private loadBikes(): void {
    this.bikeService.getBikes().subscribe((bikes: Bike[]) => {
      this.allBikes = bikes;
      this.availableBikes = [];
      this.rentedBikes = [];
      this.splitBikes();
    });
  }

  private splitBikes(): void {
    this.allBikes.forEach((bike) => {
      if(bike.status == Status.Free) {
        this.availableBikes.push(bike);
      } else if(bike.status == Status.Rented) {
        this.rentedBikes.push(bike);
      }
    });
    this.sumRent();
  }

  public sumRent(): number {
    let total = 0;
    this.rentedBikes?.forEach((bike: Bike) => {
      if(bike.price){
        total += bike.price;
      }
    });
    return Number(total.toFixed(2));
  }

  public createBike(): void {
    if (this.bike.title && this.bike.type && this.bike.price && this.bike.price >= 0){
      this.bikeService.createBike(this.bike).subscribe((data: Bike) => {
        this.bike.status = Status.Free;
        this.availableBikes.push(this.bike);
        this.loadBikes();
      });
    }
    else{
      alert('Please fill in all the required fields');
    }
  }

  public rentBikeById(id: number): void {
    this.bikeService.updateBikeById(id).subscribe(() => {
      this.loadBikes();
    });
  }

  public cancelBikeRentalById(id: number): void {
    this.bikeService.updateBikeById(id).subscribe(() => {
      this.loadBikes();
    });
  }

  public deleteBikeById(id: number): void {
    this.bikeService.deleteBikeById(id).subscribe(() => this.loadBikes());
  }
}