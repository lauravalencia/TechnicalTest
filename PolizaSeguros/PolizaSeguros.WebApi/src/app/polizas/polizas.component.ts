import { Component, OnInit } from '@angular/core';
import { PolizasService } from '../services/polizas.service';
import { Observable } from 'rxjs';
import { Global } from '../utilities/global';

@Component({
  selector: 'app-polizas',
  templateUrl: './polizas.component.html',
  styleUrls: ['./polizas.component.css']
})
export class PolizasComponent implements OnInit {

    msg: string;
    risks: Array<any>;

    constructor(private _polizasService: PolizasService) { }

    ngOnInit(): void {
       this.LoadRisks();
    }

    LoadRisks(): void {
        this._polizasService.getRisk(Global.RISKS_ENDPOINT)
            .subscribe(risks => { this.risks = risks.OprationSuccess ? risks.ObjectResponse.TiposRiesgo : [] },
                error => this.msg = <any>error); 
    }
}
