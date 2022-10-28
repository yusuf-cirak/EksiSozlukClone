import { Injectable } from '@angular/core';
import { entries } from './mock-entry';

@Injectable({
  providedIn: 'root'
})
export class EntryService {

  constructor() { }

  getEntries(){
    return entries;
  }
}
