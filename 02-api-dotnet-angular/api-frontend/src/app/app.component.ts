import { Component, OnInit, inject } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterOutlet } from '@angular/router';
import { HttpClient } from '@angular/common/http';
import { Player } from './models/player';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [CommonModule, RouterOutlet],
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss'],
})
export class AppComponent implements OnInit{

  ngOnInit(): void {
    this.getPlayerList();
  }

  title = 'api-frontend';

  http = inject(HttpClient);

  url = 'http://localhost:5170/';

  playerList: Player[] = [];

  getPlayerList() {
    this.http
      .get<Player[]>(`${this.url}playerlist`)
      .subscribe((playerList) => (this.playerList = playerList));
  }
}
