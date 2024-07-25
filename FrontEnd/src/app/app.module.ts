import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { TablaVentasComponent } from './components/tabla-ventas/tabla-ventas.component';
import { CrearVentasComponent } from './components/crear-ventas/crear-ventas.component';

@NgModule({
  declarations: [
    AppComponent,
    TablaVentasComponent,
    CrearVentasComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
