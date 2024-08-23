import { Injectable } from '@angular/core';
import { enviroment } from '../../../enviroments';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
const baseUrl = enviroment.url + 'ventas'
@Injectable({
  providedIn: 'root'
})
export class TablaVentasService {

  constructor(protected _httpClient: HttpClient) {
  }
  getTablaVenta(): Observable<any>{
    return this._httpClient.get(baseUrl)
  }
}
