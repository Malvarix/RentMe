import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { RentComponent } from './bike/rent/rent.component';
import { FormsModule } from '@angular/forms';
import { BikeService } from './shared/bike.service';
import { HttpClientModule } from '@angular/common/http';

@NgModule({
  declarations: [
    AppComponent,
    RentComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule
  ],
  providers: [BikeService],
  bootstrap: [AppComponent]
})
export class AppModule { }
