import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { RentComponent } from './bike/rent/rent.component';

const routes: Routes = [
  { path: '', pathMatch: 'full', redirectTo: 'rent' },
  { path: 'rent', component : RentComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
