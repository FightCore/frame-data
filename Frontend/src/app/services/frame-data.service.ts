import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { ExtendedCharacter } from '../models/extended-character';

@Injectable({
  providedIn: 'root',
})
export class FrameDataService {
  constructor(private httpClient: HttpClient) {}

  getMoves(): Observable<ExtendedCharacter[]> {
    return this.httpClient.get<ExtendedCharacter[]>(`https://data.fightcore.gg/v2/framedata.json`);
  }

  getMovesForCharacter(characterName: string): Observable<ExtendedCharacter> {
    return this.httpClient.get<ExtendedCharacter>(`https://data.fightcore.gg/v2/${characterName}.json`);
  }
}
