import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Character, Move } from '@fightcore/models';
import { select, Store } from '@ngrx/store';
import { selectMove } from 'src/app/store/frame-data/frame-data.selectors';
import { Meta, Title } from '@angular/platform-browser';
import { MetaTagService } from 'src/app/services/meta-tag.service';
import { CanonicalService } from 'src/app/services/canonical.service';

@Component({
  selector: 'app-move',
  templateUrl: './move.component.html',
  styleUrls: ['./move.component.scss'],
})
export class MoveComponent implements OnInit {
  character?: Character;
  move?: Move;

  constructor(
    private store: Store,
    private activatedRoute: ActivatedRoute,
    private metaTagService: MetaTagService,
    private title: Title,
    private canonicalService: CanonicalService
  ) {}
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

        this.title.setTitle(`${this.character.name} - ${move.name} | FightCore - Melee Frame Data`);
        this.metaTagService.updateMoveTags(move, this.character);
        this.canonicalService.createLinkForMove(this.character, this.move as Move);
      });
  }
}
