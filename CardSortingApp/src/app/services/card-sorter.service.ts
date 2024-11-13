import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class CardSorterService {
  private apiUrl = 'https://localhost:44318/api/Card';

  constructor(private http: HttpClient) {}

  sortCards(cards: string[]): Observable<string[]> {
    return this.http.post<any>(this.apiUrl, cards);
  }
}
