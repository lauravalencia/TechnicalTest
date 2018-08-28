import { Injectable } from '@angular/core';
import { HttpClient, HttpParams, HttpErrorResponse } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { catchError } from 'rxjs/operators';

@Injectable()
export class PolizasService {

    constructor(private _http: HttpClient) { }

    getRisk(url: string): Observable<any> {
        return this._http.get(url).pipe(catchError(this.handleError));
    }  

    private handleError(error: HttpErrorResponse) {
        if (error.error instanceof ErrorEvent) { 
            console.error('Ha ocurrido un error:', error.error.message);
        }
        return throwError('Ha ocurrido un error interno. Intente más tarde.');
    }  
}
