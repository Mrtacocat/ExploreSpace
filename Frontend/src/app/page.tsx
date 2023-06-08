import Link from "next/link";
import styles from "./styles/Home.module.css";

export default function Home() {
  return (
      
    <section className={styles.hero}>
      <header id={styles.header}>
          <Link href="/Login">logo</Link>
        <nav>
          <a id="menu-icon">&#8801;</a>
        </nav>
      </header>
      <header className="hero-header">
        <h1 className="hero-title">The Title of this Hero Module</h1>
      </header>
      <footer className={styles.herofooter}>
        <a className="button button-primary" href="#">
          button one
        </a>
        <a className="button" href="#">
          button two
        </a>
      </footer>
    </section>
  );
}
