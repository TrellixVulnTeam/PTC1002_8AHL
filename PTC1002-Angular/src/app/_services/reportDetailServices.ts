import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
// import { environment } from 'src/environments/environment.prod';

@Injectable({
  providedIn: 'root'
})
export class ReportDetailService {
  baseUrl = environment.apiUrl + 'NumberGenerator/';
  
  constructor(private http: HttpClient){ }
  viewRandomNumberReport() {
    
    return this.http.get(this.baseUrl + 'viewRandomNumberReport');
  }
  
}
