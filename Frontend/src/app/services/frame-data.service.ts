import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Character } from '../models/character';

@Injectable({
  providedIn: 'root',
})
export class FrameDataService {
  constructor(private httpClient: HttpClient) {}

  getMoves(): Observable<Character[]> {
    return this.httpClient.get<Character[]>(`${environment.siteUrl}/framedata.json`);
  }
}
