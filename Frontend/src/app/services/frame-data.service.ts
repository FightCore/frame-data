import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { FrameDataCharacter } from '../models/framedata-character';
import { Move } from '../models/move';

@Injectable({
  providedIn: 'root',
})
export class FrameDataService {
  constructor(private httpClient: HttpClient) {}

  getFrameDataForCharacter(characterId: number): Observable<FrameDataCharacter> {
    return this.httpClient.get<FrameDataCharacter>(`${environment.baseUrl}/framedata/${characterId}`);
  }

  getCharacters(): Observable<FrameDataCharacter[]> {
    return this.httpClient.get<FrameDataCharacter[]>(`${environment.baseUrl}/framedata/characters`);
  }

  getMove(moveId: number): Observable<Move> {
    return this.httpClient.get<Move>(`${environment.baseUrl}/framedata/moves/${moveId}`);
  }

  getMoves(moveId?: number): Observable<FrameDataCharacter[]> {
    return this.httpClient.get<FrameDataCharacter[]>(`${environment.siteUrl}/framedata.json`);
  }
}
