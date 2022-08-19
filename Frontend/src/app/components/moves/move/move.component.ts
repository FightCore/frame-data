import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { FrameDataCharacter } from 'src/app/models/framedata-character';
import { Move } from 'src/app/models/move';
import { FrameDataService } from 'src/app/services/frame-data.service';
import { select, Store } from '@ngrx/store';
import {
  selectCharacter,
  selectMove,
} from 'src/app/store/frame-data/frame-data.selectors';
import { filter, pipe } from 'rxjs';
import { loadCharacters } from 'src/app/store/frame-data/frame-data.actions';

@Component({
  selector: 'app-move',
  templateUrl: './move.component.html',
  styleUrls: ['./move.component.scss'],
})
export class MoveComponent implements OnInit {
  character?: FrameDataCharacter;
  move?: Move;

  constructor(private store: Store, private activatedRoute: ActivatedRoute) {}
  ngOnInit(): void {
    const characterId =
      this.activatedRoute.snapshot.paramMap.get('characterId');
    const moveId = this.activatedRoute.snapshot.paramMap.get('moveId');

    if (!characterId || !moveId) {
      console.log('Bad ids');
      return;
    }
    this.store
      .pipe(
        select(
          selectMove({
            characterId: parseFloat(characterId),
            moveId: parseFloat(moveId),
          })
        )
      )
      .subscribe((move) => {
        console.log('Move', move);
        this.move = move;
      });

    this.store
      .pipe(select(selectCharacter({ characterId: parseFloat(characterId) })))
      .subscribe((character) => {
        console.log('Char', character);
        this.character = character;
      });
  }
}
