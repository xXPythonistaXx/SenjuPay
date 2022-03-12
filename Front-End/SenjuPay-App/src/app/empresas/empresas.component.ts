import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-empresas',
  templateUrl: './empresas.component.html',
  styleUrls: ['./empresas.component.scss']
})
export class EmpresasComponent implements OnInit {


  public empresas: any;

  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.http.get('https://localhost:5001/api/empresa').subscribe(
      response => this.empresas = response,
      error => console.log(error)
    );
  }

}
