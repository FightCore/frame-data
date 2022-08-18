import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { FrameDataCharacter } from 'src/app/models/framedata-character';
import { MoveType } from 'src/app/models/move-type';
import { FrameDataService } from 'src/app/services/frame-data.service';

@Component({
  selector: 'app-character',
  templateUrl: './character.component.html',
  styleUrls: ['./character.component.scss'],
})
export class CharacterComponent implements OnInit {
  character?: FrameDataCharacter;

  moveTypes = [
    { name: 'Moves.Categories.GroundedAttacks', value: MoveType.grounded },
    { name: 'Moves.Categories.TiltAttacks', value: MoveType.tilt },
    { name: 'Moves.Categories.AerialAttacks', value: MoveType.air },
    { name: 'Moves.Categories.SpecialAttacks', value: MoveType.special },
    { name: 'Moves.Categories.Throws', value: MoveType.throw },
    { name: 'Moves.Categories.Dodges', value: MoveType.dodge },
    { name: 'Moves.Categories.Unknown', value: MoveType.unknown },
  ];
  constructor(
    private frameDataService: FrameDataService,
    private activatedRoute: ActivatedRoute
  ) {}

  ngOnInit(): void {
    const characterId =
      this.activatedRoute.snapshot.paramMap.get('characterId');
    if (!characterId) {
      return;
    }
    this.frameDataService
      .getFrameDataForCharacter(parseFloat(characterId))
      .subscribe((character) => {
        this.character = character;
      });
  }

  navigateToCategory(value: number) {
    const el = document.getElementById('category-' + value);
    if (el) {
      el.scrollIntoView({ behavior: 'smooth' });
    }
  }
}
