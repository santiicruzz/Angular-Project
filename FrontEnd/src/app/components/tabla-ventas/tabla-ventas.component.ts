import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { TablaVentasService } from '../../core/services/tabla-ventas.service'

@Component({
  selector: 'app-tabla-ventas',
  templateUrl: './tabla-ventas.component.html',
  styleUrl: './tabla-ventas.component.css'
})
export class TablaVentasComponent implements OnInit{
  tablaMoto: any = [];
  constructor(private router: Router, private service: TablaVentasService) {}

  ngOnInit(): void {
    this.getData();
  }

  getData(){
    this.service.getTablaVenta().subscribe((data)=>{
      this.tablaMoto = data;
    });
      
  }
  
  navegar() {
    this.router.navigate(['/crear-ventas']);
  };
}