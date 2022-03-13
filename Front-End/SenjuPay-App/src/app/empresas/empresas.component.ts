import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-empresas',
  templateUrl: './empresas.component.html',
  styleUrls: ['./empresas.component.scss']
})
export class EmpresasComponent implements OnInit {

  public empresas: any = [];
  showImage: boolean = true;
  private filterIn: string = '';
  public empresasFiltradas: any = [];

  public get empresasFilter(): string {
    return this.filterIn
  }
  public set empresasFilter(value: string) {
     this.filterIn = value;
     this.empresasFiltradas = this.empresasFilter ? this.empresaFilter(this.filterIn): this.empresas
  }
  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.getEmpresas();
  }

  public getEmpresas(): void{
    this.http.get('https://localhost:5001/api/empresa').subscribe(
      response => {
        this.empresas = response,
        this.empresasFiltradas = this.empresas
      },
      error => console.log(error)
    );
  }

  changeImage(){
    this.showImage = !this.showImage;
  }

  empresaFilter(filterIn: string): any {
    filterIn = filterIn.toLocaleLowerCase();
    return this.empresas.filter(
      (empresa: any) => empresa.razaoSocial.toLocaleLowerCase().indexOf(filterIn) !== -1 ||
       empresa.razaoSocial.toLocaleLowerCase().indexOf(filterIn) !== -1 ||
       empresa.cnpj.toString().toLocaleLowerCase().indexOf(filterIn) !== -1
    )
  }


}
