import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';


@Component({
  selector: 'app-tabla-ventas',
  templateUrl: './tabla-ventas.component.html',
  styleUrl: './tabla-ventas.component.css'
})
export class TablaVentasComponent implements OnInit{
  tablaMoto: any = [
                    {"id": 1, "marca": "yamaha", "cilindraje": "150", "modelo": "2024", "precio": "8500000","MetodoPago": "efectivo", "FechaVenta": "2024/07/19"},
                    {"id": 2, "marca": "bajaj", "cilindraje": "125", "modelo": "2017", "precio": "6750000","MetodoPago": "PSE", "FechaVenta": "2024/07/19"},
                    {"id": 3, "marca": "honda", "cilindraje": "300", "modelo": "2016", "precio": "23450000","MetodoPago": "Tarjeta de credito", "FechaVenta": "2024/07/19"},
                    {"id": 4, "marca": "tvs", "cilindraje": "180", "modelo": "2023", "precio": "9125000","MetodoPago": "efectivo", "FechaVenta": "2024/07/19"},
                    {"id": 5, "marca": "suzuki", "cilindraje": "250", "modelo": "2022", "precio": "16430000","MetodoPago": "pse", "FechaVenta": "2024/07/19"},
                    {"id": 6, "marca": "victory", "cilindraje": "125", "modelo": "2015", "precio": "8750000","MetodoPago": "efectivo", "FechaVenta": "2024/07/19"}
                  ];
  constructor(private router: Router) {}

  ngOnInit(): void {
  }
  
  navegar() {
    this.router.navigate(['/crear-ventas']);
  };
}