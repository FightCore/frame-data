import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { FrameDataCharacter } from 'src/app/models/framedata-character';
import { Move } from 'src/app/models/move';
import { FrameDataService } from 'src/app/services/frame-data.service';

@Component({
  selector: 'app-move',
  templateUrl: './move.component.html',
  styleUrls: ['./move.component.scss'],
})
export class MoveComponent implements OnInit {
  character?: FrameDataCharacter;
  move?: Move;

  constructor(
    private frameDataService: FrameDataService,
    private activatedRoute: ActivatedRoute
  ) {}

  ngOnInit(): void {
    const characterId =
      this.activatedRoute.snapshot.paramMap.get('characterId');
    const moveId = this.activatedRoute.snapshot.paramMap.get('moveId');
    if (!characterId || !moveId) {
      return;
    }
    this.frameDataService
      .getFrameDataForCharacter(parseFloat(characterId))
      .subscribe((character) => {
        this.character = character;
        this.move = this.character.moves.find(
          (move) => move.id === parseFloat(moveId)
        );
      });
  }
}
