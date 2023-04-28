import { Component, OnInit } from '@angular/core';
import { Title } from '@angular/platform-browser';
import { select, Store } from '@ngrx/store';
import { map } from 'rxjs';
import { Move } from '@fightcore/models';
import { selectMoves } from 'src/app/store/frame-data/frame-data.selectors';
import { isDarkMode } from 'src/app/store/user-settings/user-settings.selectors';

@Component({
  selector: 'app-moves',
  templateUrl: './moves.component.html',
  styleUrls: ['./moves.component.scss'],
})
export class MovesComponent implements OnInit {
  moves: Move[] = [];
  useDarkMode = false;
  constructor(private store: Store, private title: Title) {
    this.store.pipe(select(isDarkMode())).subscribe((useDarkMode) => {
      this.useDarkMode = useDarkMode;
    });
  }

  ngOnInit(): void {
    this.title.setTitle('Moves | FightCore - Melee Frame Data');
    this.store
      .pipe(select(selectMoves()))
      .pipe(
        map((moves) => {
          if (moves) {
            return moves;
          }

          return [];
        })
      )
      .subscribe((moves) => {
        this.moves = moves;
      });
  }
}
