import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class EventosService {

constructor(private http: HttpClient) { }

public getEventos(): any {
  this.http.get('https://localhost:7127/api/eventos')
    .subscribe(
      response => response,
      error => console.log(error)
    );
}
}
