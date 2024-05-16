import { isPlatformBrowser } from '@angular/common';
import { Component, Inject, Input, OnInit, PLATFORM_ID } from '@angular/core';
import { Router } from '@angular/router';
import slugify from 'slugify';
import { Move } from '@fightcore/models';

@Component({
  selector: 'app-move-card',
  templateUrl: './move-card.component.html',
  styleUrls: ['./move-card.component.scss'],
})
export class MoveCardComponent {
  @Input() move?: Move;
  @Input() characterName?: string;
  @Input() characterId?: number;
  @Input() useAltBackground = false;

  moveUrl(): string {
    return `/characters/${this.characterId!}/${slugify(this.characterName!)}/moves/${this.move!.id}/${slugify(
      this.move!.name
    )}`;
  }
}
