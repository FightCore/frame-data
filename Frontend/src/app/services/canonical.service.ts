import { Inject, Injectable } from '@angular/core';
import { DOCUMENT } from '@angular/common';
import { Character } from '../models/character';
import slugify from 'slugify';
import { Move } from '../models/move';

@Injectable({
  providedIn: 'root',
})
export class CanonicalService {
  private readonly fightCoreUrl = 'https://www.fightcore.gg/';

  constructor(@Inject(DOCUMENT) private document: Document) {}

  createLinkForCharacter(character: Character): void {
    this.createLinkForCanonicalURL(
      `${this.fightCoreUrl}characters/${character.fightCoreId}/${slugify(character.name)}`
    );
  }

  createLinkForMove(character: Character, move: Move): void {
    this.createLinkForCanonicalURL(
      `${this.fightCoreUrl}characters/${character.fightCoreId}/${slugify(character.name)}/moves/${move.id}/${slugify(
        move.name
      )}`
    );
  }

  createLinkForCompare(): void {
    this.createLinkForCanonicalURL(`${this.fightCoreUrl}compare-tool`);
  }

  createLinkForCharacters(): void {
    this.createLinkForCanonicalURL(`${this.fightCoreUrl}characters`);
  }

  private createLinkForCanonicalURL(url: string): void {
    let link: HTMLLinkElement | null = this.getLink();

    if (!link) {
      link = this.document.createElement('link');
    }

    link.setAttribute('rel', 'canonical');
    this.document.head.appendChild(link);
    link.setAttribute('href', url);
  }

  private getLink(): HTMLLinkElement | null {
    return this.document.querySelector('[rel="canonical"]') as HTMLLinkElement;
  }
}
