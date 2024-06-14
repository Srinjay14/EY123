import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Idata } from './Idata';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class SharedService {

  constructor(private httpClient:HttpClient) { }

  public getPosts():Observable<Idata[]>{
    return this.httpClient.get<Idata[]>('https://jsonplaceholder.typicode.com/posts');
  }
}
