import { Component, OnInit, inject } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterOutlet } from '@angular/router';
import { HttpClient } from '@angular/common/http';
import { Player } from './models/player';
import { Observable } from 'rxjs';
import { MatTableModule } from '@angular/material/table';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [CommonModule, RouterOutlet, MatTableModule],
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss'],
  host: {ngSkipHydration: 'true'},
})
export class AppComponent {
  // ngOnInit(): void {
  //   this.getPlayerList();
  // }

  constructor(private http: HttpClient) {}

  title = 'api-frontend';

  // http = inject(HttpClient);

  url = 'http://localhost:5170/';

  playerList$?: Observable<Player[]>;

  getPlayerList() {
    this.playerList$ = this.http.get<Player[]>(`${this.url}playerlist`);
  }

  shouldSayHello: boolean = true;

  switchHello() {
    this.shouldSayHello = !this.shouldSayHello;
  }
}
