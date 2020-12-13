import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Bike } from '../bike/entities/bike';
import { Observable } from 'rxjs';

@Injectable()
export class BikeService {

    private url = 'https://localhost:5001/api/bikes';

    constructor(private http: HttpClient) {}
    
    getBikeById(id: number): Observable<Bike> {
      return this.http.get<Bike>(this.url + '/' + id);
    }
    getBikes(): Observable<Bike[]> {
        return this.http.get<Bike[]>(this.url);
    }
    createBike(bike: Bike): Observable<Bike> {
        return this.http.post(this.url, bike);
    }
    updateBikeById(id: number): Observable<any> {
        return this.http.put(this.url, id);
    }
    deleteBikeById(id: number): Observable<any> {
        return this.http.delete(this.url + '/' + id);
    }
}