import { Injectable } from '@angular/core';
import { Http, Response, Headers } from '@angular/http';
import { Observable } from 'rxjs';

@Injectable()
export class PolizasService {

  constructor(private http: Http) { }

    getRisks(url: string) {
        return this._http.get(url)
            .map((response: Response) => response.json())
            .catch(this.handleError);
    }

    private handleError(error: Response) {
        console.error(error);
        return throw new Error(error.json().error || 'Server error');
    }
}
