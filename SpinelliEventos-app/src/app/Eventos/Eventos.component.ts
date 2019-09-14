import { Component, OnInit } from '@angular/core';
import {HttpClient} from '@angular/common/http';

@Component({
  selector: 'app-eventos',
  templateUrl: './Eventos.component.html',
  styleUrls: ['./Eventos.component.css']
})
export class EventosComponent implements OnInit {

  constructor(private http: HttpClient) { }

  eventos: any;



  ngOnInit() {

    this.eventos = this.http.get('http://localhost:5000/api/values').subscribe(
      res => {
        this.eventos = res;
      }
    );
  }

}
