import { Component, Input, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { FrameDataCharacter } from 'src/app/models/framedata-character';
import slugify from 'slugify';

@Component({
  selector: 'app-character-preview-card',
  templateUrl: './character-preview-card.component.html',
  styleUrls: ['./character-preview-card.component.scss'],
})
export class CharacterPreviewCardComponent {
  @Input() character?: FrameDataCharacter;
  constructor(private router: Router) {}

  onClickViewCharacter(): void {
    this.router.navigate([
      `/characters/${this.character?.fightCoreId}/${slugify(
        this.character!.name
      )}`,
    ]);
  }
}
