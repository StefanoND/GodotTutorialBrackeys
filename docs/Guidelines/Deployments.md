# Deployment

- Start local > Staging > Release Candidate (RC) > Production
  1. Copy the project and make changes/experment with/updates locally
  2. Once it's good enough, create its own specific branch
  3. Create or merge to a staging branch
  4. Bugfix where needed
  5. Create or merge to a RC (Release Candiate) branch
  6. Once it's tested and (mostly) bug-free, merge to Production branch
  7. If any changes, updates, fixes is needed on Production repeat steps 1-6.

- Use CI/CD pipelines (GitHub Actions, etc)

- Write deployment notes for future-you/colleagues

## Recommended branch names

- Local: No name
- Specific Branch: System/Feature name
- Staging: Staging or Dev
- Release Candidate: RC or Beta
- Production: Main or Master
