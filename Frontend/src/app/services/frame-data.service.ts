import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Character } from '@fightcore/models';
import { ExtendedCharacter } from '../models/extended-character';

@Injectable({
  providedIn: 'root',
})
export class FrameDataService {
  constructor(private httpClient: HttpClient) {}

  getMoves(): Observable<ExtendedCharacter[]> {
    return this.httpClient.get<ExtendedCharacter[]>(`${environment.siteUrl}/assets/framedata/framedata.json`);
  }

  getMovesForCharacter(characterName: string): Observable<ExtendedCharacter> {
    return this.httpClient.get<ExtendedCharacter>(`${environment.siteUrl}/assets/framedata/${characterName}.json`);
  }
}
