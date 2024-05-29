import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { EventosService } from './eventos.service';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.scss']
})
export class EventosComponent implements OnInit {

  public eventos: any;

  constructor(private http: HttpClient) { }

  ngOnInit(): void {
    this.getEventos();
  }

  public getEventos(): void {
    this.http.get('https://localhost:7127/api/eventos')
    .subscribe(
      response => this.eventos = response,
      error => console.log(error)
    );
    
    // this.eventos = [
    //   {
    //     Tema: 'Angular 11',
    //     Local: 'Belo Horizonte'
    //   },
    //   {
    //     Tema: '.Net 5',
    //     Local: 'São Paulo'
    //   },
    //   {
    //     Tema: 'Godot 4',
    //     Local: 'Ipatinga'
    //   }
    // ]
  }
}
