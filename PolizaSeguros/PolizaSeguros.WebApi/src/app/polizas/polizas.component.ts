import { Component, OnInit } from '@angular/core';
import { PolizasService } from '../services/polizas.service';
import { Global } from '../utilities/global';

@Component({
  selector: 'app-polizas',
  templateUrl: './polizas.component.html',
  styleUrls: ['./polizas.component.css']
})
export class PolizasComponent implements OnInit {

    msg: string;

    constructor(private _polizasService: PolizasService) { }

  ngOnInit() {
  }
    LoadRisks(): void {
        this._polizasService.getRisks(Global.RISKS_ENDPOINT)
            .subscribe(risks => 
                error => this.msg = <any>error);
    }
}
