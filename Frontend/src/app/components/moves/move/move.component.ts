import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { FrameDataCharacter } from 'src/app/models/framedata-character';
import { Move } from 'src/app/models/move';
import { select, Store } from '@ngrx/store';
import { selectMove } from 'src/app/store/frame-data/frame-data.selectors';
import { Meta, Title } from '@angular/platform-browser';

@Component({
  selector: 'app-move',
  templateUrl: './move.component.html',
  styleUrls: ['./move.component.scss'],
})
export class MoveComponent implements OnInit {
  character?: FrameDataCharacter;
  move?: Move;

  constructor(private store: Store, private activatedRoute: ActivatedRoute, private meta: Meta, private title: Title) {}
  ngOnInit(): void {
    const characterId = this.activatedRoute.snapshot.paramMap.get('characterId');
    const moveId = this.activatedRoute.snapshot.paramMap.get('moveId');

    if (!characterId || !moveId) {
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
        this.move = move;
        this.character = move?.character;

        if (!move || !this.character) {
          return;
        }
        this.title.setTitle(`${this.character.name} - ${move.name} - FightCore`);
      });
  }
}
