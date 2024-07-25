import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { TablaVentasComponent } from './components/tabla-ventas/tabla-ventas.component';
import { CrearVentasComponent } from './components/crear-ventas/crear-ventas.component';

const routes: Routes = [
  {path:'', component: TablaVentasComponent},
  {path:'crear-ventas', component: CrearVentasComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
