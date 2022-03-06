import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-empresas',
  templateUrl: './empresas.component.html',
  styleUrls: ['./empresas.component.scss']
})
export class EmpresasComponent implements OnInit {


  public empresas: any;

  constructor() { }

  ngOnInit() {
    this.getEmpresas();
  }

  public getEmpresas(): void{
    this.empresas = [
      {
        Razao: 'guizin',
        CNPJ: '1243432'
      },

      {
        Razao: 'Juliana e Marcos Vinicius Pães e Doces ME',
        CNPJ: '34544287000132'
      },

      {
        Razao: 'GERARPARCELASPORDOCUMENTO',
        CNPJ: '329487623897643'
      }
    ]
  }

}
