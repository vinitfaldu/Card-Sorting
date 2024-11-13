import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CardSorterComponent } from './components/card-sorter/card-sorter.component';

const routes: Routes = [
  { path: 'card', component: CardSorterComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
