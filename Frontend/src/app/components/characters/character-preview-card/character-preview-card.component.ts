import { Component, Input, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Character } from 'src/app/models/character';
import slugify from 'slugify';
import { environment } from 'src/environments/environment';

@Component({
  selector: 'app-character-preview-card',
  templateUrl: './character-preview-card.component.html',
  styleUrls: ['./character-preview-card.component.scss'],
})
export class CharacterPreviewCardComponent {
  @Input() character?: Character;
  environment = environment;
  constructor() {}

  viewCharacterUrl(): string {
    return `/characters/${this.character?.fightCoreId}/${slugify(this.character!.name)}`;
  }
}
