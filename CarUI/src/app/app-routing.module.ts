import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { PageContentComponent } from './share/page-content/page-content.component';

const routes: Routes = [
  { path: 'order', component: PageContentComponent},
  { path: '', redirectTo: 'order', pathMatch: 'full' },   // default route
  { path: '**', redirectTo: 'order', pathMatch: 'full' }, // 404 not found page
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
